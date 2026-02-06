using Bunit;
using Microsoft.Extensions.DependencyInjection;
using R66.Shared;
using R66.State;

namespace TestR66
{
  [Collection("R66")]
  public class TestRoot
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavDrawerModule),
        typeof(IgbDatePickerModule));
      ctx.Services.AddScoped<IStateService>(sp => new MockStateService());
      var componentUnderTest = ctx.RenderComponent<Root>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
