// mecanismo de eventos para captura dos eventos de teclado
//namespace ProjetoFinal_2;
using System;
using System.Windows.Forms;
namespace WindowsFormsApplication1;


public class JewelCollector 
{
    public event EventHandler Keyaction;
    protected virtual void onKeyaction(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            MessageBox.Show("Enter key pressed");
        }
        if (e.KeyChar == 13)
        {
            MessageBox.Show("Enter key pressed");
        }
    }  
}
