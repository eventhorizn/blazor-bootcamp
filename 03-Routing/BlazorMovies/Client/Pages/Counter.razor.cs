using BlazorMovies.Shared.Entities; // _Imports only applies to .razor files not .cs files
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static BlazorMovies.Client.Shared.MainLayout;

namespace BlazorMovies.Client.Pages
{
    // For those who don't want the code in the @code section of the razor page
    // Not a terrible idea if the html and code get big
    public partial class Counter
    {
        // Other way to do injection, but in a code file
        [Inject] SingeltonService Singelton { get; set; }
        [Inject] TransientService Transient { get; set; }
        [Inject] IJSRuntime js { get; set; }

        // This allows us to retrieve the Color defined in 'MainLayout'
        // One way, better way is to create an AppState object
        //[CascadingParameter(Name = "Color")] public string Color { get; set; }
        //[CascadingParameter(Name = "Size")] public string Size { get; set; }

        [CascadingParameter] public AppState AppState { get; set; }

        private Dictionary<string, object> dummyTextboxParameters = new Dictionary<string, object>()
        {
            { "placeholder", "Movie Name" },
            { "disabled", "true" }
        };

        private List<Movie> movies;

        protected override void OnInitialized()
        {
            //await Task.Delay(1000);

            movies = new List<Movie>()
            {
                new Movie(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2)},
                new Movie(){Title = "Avengers", ReleaseDate = new DateTime(2016, 11, 23)}
            };
        }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singelton.Value = currentCount;
            currentCountStatic++;
            await js.InvokeVoidAsync("dotNetStaticInvocation");
        }

        // So, we added a new button that calls this
        // This calls our JavaScript function
        // The js function then calls this class's IncrementCount function
        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotNetInstanceInvocation", 
                DotNetObjectReference.Create(this));
        }

        // Invoking static C# methods from js
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

    }
}
