using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharpTraining
{
    class Keywords
    {
        public static void UsingKeywords()
        {
            // Exploring keywords
            System.Diagnostics.Debug.WriteLine("--- Exploring some of the C# keywords ---");
            var keywords = new List<string>()
            {
                "abstract", "as", "base", "bool", "break", "byte",
                "case", "catch", "char", "checked", "class", "const", "continue", "decimal",
                "default", "delegate", "do", "double", "else", "enum", "event", "explicit",
                "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if",
                "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
                "new", "null", "object", "operator", "out", "override", "params", "private",
                "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
                "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw",
                "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using",
                "virtual", "void", "volatile", "while" 
            };
            foreach(var item in keywords)
                System.Diagnostics.Debug.Write($"{item}, ");

            // Exploring contextual keywords
            // A contextual keyword is used to provide a specific meaning in the code, but it is not a reserved word in C#
            System.Diagnostics.Debug.WriteLine("\n--- Exploring some of the C# contextual keywords ---");
            var contextualKeywords = new List<string>()
            {
                "add", "alias", "ascending", "async", "await", "by", "descending", "dynamic",
                "equals", "from", "get", "global", "group", "into", "join", "let", "nameof", "on",
                "orderby", "partial(type)", "partial(method)", "remove", "select", "set",
                "unmanaged(generic type constraint)", "value", "var", "when(filter condition)",
                "where(generic type constraint)", "where(query clause)", "yield"
            };
            foreach (var item in contextualKeywords)
                System.Diagnostics.Debug.Write($"{item}, ");

        }
    }
}