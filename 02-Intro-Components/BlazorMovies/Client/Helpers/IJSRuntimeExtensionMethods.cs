using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "example message");
            return await js.InvokeAsync<bool>("confirm", message);
        }

        // Calling a custom js function
        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("my_function", message);
        }
    }
}
