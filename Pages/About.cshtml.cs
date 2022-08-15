using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood.Pages;

public class AboutModel : PageModel

{
    private string _message { get; set; }

    public string Message { get; set; }

    public AboutModel(string _message)
    {
        Message = _message;
    }

    public string OnGet()
    {
        return Message;
    }
}

