using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public class MenuRendererConImagenes : ToolStripProfessionalRenderer
{
    public MenuRendererConImagenes() : base(new ProfessionalColorTable()) { }

    // No dibujar el fondo para los elementos seleccionados
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        // Verificar si el item está seleccionado, pero no hacer nada
        // Esto previene que el fondo cambie y elimine las imágenes
        if (e.Item.Selected)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), e.Item.Bounds);
        }
        else
        {
            base.OnRenderMenuItemBackground(e);  // Mantener el fondo original para los demás casos
        }
    }

    // Asegurarse de que las imágenes se rendericen correctamente sin ser sobreescritas
    protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
    {
        // Solo renderizar la imagen si existe, sin hacer nada extra
        if (e.Image != null)
        {
            e.Graphics.DrawImage(e.Image, e.ImageRectangle);
        }
    }

    // Asegurarse de que el texto también se dibuje correctamente
    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        base.OnRenderItemText(e);  // Permitir que el texto se dibuje normalmente si es necesario
    }
}
