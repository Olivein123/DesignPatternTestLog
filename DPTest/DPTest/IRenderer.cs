using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public interface IRenderer
    {
        /// <summary>
        /// Creates objects based on theme provided
        /// </summary>
        /// <param name="theme"></param>
        void RenderUserInterface(string? theme);

        /// <summary>
        /// Creates Texts based on given theme
        /// </summary>
        /// <param name="text"></param>
        /// <param name="theme"></param>
        /// <returns></returns>
        string CreateText(string text, string theme);

        /// <summary>
        /// Creates a button made out of Text based on given theme
        /// </summary>
        /// <param name="theme"></param>
        /// <returns></returns>
        string CreateButton(string theme);
    }
}

