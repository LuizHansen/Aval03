using System;
using System.Text;

class Program
{
    static void Main()
    {
        string cesar = "Lu0s z q0tm0uƒ€q~x ƒ40t ‚uy~t (~ 0†w|q~„mPe}q(†ytq(q‚q‚i0…}0uy~…„w0y‚‚m|u†qv„uPeu0q„qy…u0tm0 † (u}0†é‚yqƒ(s ‚u{0u0„i}q~xwƒPTqvt 0ri|qƒ0m0sywi‚‚ ƒ(u0sqz ~qƒ(q0uƒ|‚q~xwƒPSqz‚ ƒ0wƒƒ 0lyŠu~l 0ƒyuP_0ƒq~q|0o‚y„qvt 0~ë PTu~u0ƒuz0yƒƒw0 …u(sxq}i}0tu(‚uƒƒ}‚uy÷ë PPSi€y„qt0Y~ykyq|PZuƒƒ…z‚uy÷ë";
        string decifrada = DecodificarMensagem(cesar);
        decifrada = decifrada.Replace("@", "\n");
        Console.WriteLine(decifrada.ToUpper());
    }

    static string DecodificarMensagem(string cesar)
    {
        StringBuilder decifrada = new StringBuilder();

        for (int i = 0; i < cesar.Length; i++)
        {
            int caractere = Convert.ToInt32(cesar[i]);

            int chave = (i % 5 == 0) ? 8 : 16;

            char caractereDecifrado = (char)(caractere - chave);

            decifrada.Append(caractereDecifrado);
        }

        return decifrada.ToString();
    }
}
