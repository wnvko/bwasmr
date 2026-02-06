using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Pages.Numeric_path_no_value;
using Microsoft.AspNetCore.Components;

namespace TestR66
{
  [Collection("R66")]
  public class TestNumeric_query_4
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var routeData = new RouteData(typeof(Numeric_query_4), new Dictionary<string, object>());
      ctx.Services.AddSingleton(routeData);
      var componentUnderTest = ctx.RenderComponent<Numeric_query_4>(p => p.AddCascadingValue(routeData));
      Assert.NotNull(componentUnderTest);
    }
  }
}
