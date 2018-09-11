using Microsoft.AspNetCore.Mvc.ApplicationModels;
using RPRoutingTests.PageRouteModelConventions;
using System;
using System.Linq;
using Xunit;

namespace RoutingTests
{
    public class CustomPageRouteModelConventionTests
    {
        [Fact]
        public void Convention_GeneratesIndexRouteWithoutTrailingSlash()
        {
            var pageRouteModel = new PageRouteModel("Test/TestIndex.cshtml", "/Test/TestIndex")
            {
                Selectors =
                {
                    new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel
                        {
                            Template = "Test/TestIndex",
                        }
                    }
                }
            };

            var convention = new CustomPageRouteModelConvention();
            convention.Apply(pageRouteModel);
            var template = pageRouteModel.Selectors.ToList().First().AttributeRouteModel.Template;
            Assert.Equal("Test", template);
        }

        [Fact]
        public void Convention_GeneratesNonIndexRoute()
        {
            var pageRouteModel = new PageRouteModel("Test/TestEdit.cshtml", "/Test/TestEdit")
            {
                Selectors =
                {
                    new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel
                        {
                            Template = "Test/TestEdit",
                        }
                    }
                }
            };

            var convention = new CustomPageRouteModelConvention();
            convention.Apply(pageRouteModel);
            var template = pageRouteModel.Selectors.ToList().First().AttributeRouteModel.Template;
            Assert.Equal("Test/Edit", template);
        }

        [Fact]
        public void Convention_ThrowsApplicationExceptionForNestedFolders()
        {
            var pageRouteModel = new PageRouteModel("Test/Test/Test.cshtml", "Test/Test/Test")
            {
                Selectors =
                {
                    new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel
                        {
                            Template = "Test/Test/Test",
                        }
                    }
                }
            };

            var convention = new CustomPageRouteModelConvention();

            Exception ex = Assert.Throws<ApplicationException>(() => convention.Apply(pageRouteModel));
            Assert.Equal("Nested folders are not permitted", ex.Message);
        }

    }
}
