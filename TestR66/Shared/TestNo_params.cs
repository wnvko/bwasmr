using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Shared;

namespace TestR66
{
  [Collection("R66")]
  public class TestNo_params
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<No_params>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
