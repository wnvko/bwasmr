using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Pages;

namespace TestR66
{
  [Collection("R66")]
  public class TestOther_root_to_have_it
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Other_root_to_have_it>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
