using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Pages.No_params;
using Microsoft.AspNetCore.Components;

namespace TestR66
{
  [Collection("R66")]
  public class TestNumeric_path_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var routeData = new RouteData(typeof(Numeric_path_1), new Dictionary<string, object>());
      ctx.Services.AddSingleton(routeData);
      var componentUnderTest = ctx.RenderComponent<Numeric_path_1>(p => p.AddCascadingValue(routeData));
      Assert.NotNull(componentUnderTest);
    }
  }
}
