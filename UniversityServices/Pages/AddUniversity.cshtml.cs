using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Net.Http.Json;
using UniversityServices.Models;

namespace UniversityServices.Pages
{
    public class AddUniversityModel : PageModel
    {
		static HttpClient httpClient = new HttpClient();
        static List<University> universities = new List<University>();

		public void OnPost()
        {

        }
        public async void OnGet([FromServices] ApplicationContext context)
        {
			object? building = await httpClient.GetFromJsonAsync("", typeof(University));
		}
    }
}
