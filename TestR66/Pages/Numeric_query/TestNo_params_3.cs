using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Pages.Numeric_query;

namespace TestR66
{
  [Collection("R66")]
  public class TestNo_params_3
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<No_params_3>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
