// Contacto.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactoModel : PageModel
{
    public void OnGet()
    {
        // C�digo que se ejecuta al cargar la p�gina
    }

    public IActionResult OnPost(string nombre, string email)
    {
        // C�digo que se ejecuta al enviar el formulario (POST)
        // Aqu� puedes procesar los datos del formulario como desees

        // Por ejemplo, imprimir en la consola
        System.Console.WriteLine($"Nombre: {nombre}, Email: {email}");

        // Redirigir a otra p�gina
        return RedirectToPage("/Index");
    }
}