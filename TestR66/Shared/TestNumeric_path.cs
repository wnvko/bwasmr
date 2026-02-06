using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Shared;

namespace TestR66
{
  [Collection("R66")]
  public class TestNumeric_path
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Numeric_path>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
