function my_function(message) {
    console.log("from utilities" + message);
}

// Invoking static C# methods from js
function dotNetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        });
}

// Invoking instance C# methods from js
function dotNetInstanceInvocation(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("IncrementCount");
}

function initializeInactivityTimer(dotNetHelper) {
    var timer;
    document.onmousemove = resetTimer;
    document.onkeypress = resetTimer;

    function resetTimer() {
        clearTimeout(timer);
        timer = setTimeout(logout, 1000 * 60 * 10); //10 minutes
    }

    function logout() {
        dotNetHelper.invokeMethodAsync("Logout");
    }
}