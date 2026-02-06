using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Pages.No_params;

namespace TestR66
{
  [Collection("R66")]
  public class TestNumeric_query_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Numeric_query_1>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
