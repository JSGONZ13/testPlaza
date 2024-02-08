// Contacto.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactoModel : PageModel
{
    public void OnGet()
    {
        // Código que se ejecuta al cargar la página
    }

    public IActionResult OnPost(string nombre, string email)
    {
        // Código que se ejecuta al enviar el formulario (POST)
        // Aquí puedes procesar los datos del formulario como desees

        // Por ejemplo, imprimir en la consola
        System.Console.WriteLine($"Nombre: {nombre}, Email: {email}");

        // Redirigir a otra página
        return RedirectToPage("/Index");
    }
}