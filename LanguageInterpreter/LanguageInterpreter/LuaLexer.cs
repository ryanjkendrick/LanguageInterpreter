﻿namespace LanguageInterpreter
{
    internal class LuaLexer
    {
        private const string RESERVED = "RESERVED";
        private const string INT = "INT";
        private const string ID = "ID";

        private string[,] TokenExpressions = new string[,] {
            { @"and", null },
            { @"break", null },
            { @"do", RESERVED },
            { @"else", RESERVED },
            { @"elseif", RESERVED },
            { @"end", RESERVED },
            { @"false", RESERVED },
            { @"for", RESERVED },
            { @"function", RESERVED },
            { @"goto", RESERVED },
            { @"if", RESERVED },
            { @"in", RESERVED },
            { @"local", RESERVED },
            { @"nil", RESERVED },
            { @"not", RESERVED },
            { @"or", RESERVED },
            { @"repeat", RESERVED },
            { @"return", RESERVED },
            { @"then", RESERVED },
            { @"true", RESERVED },
            { @"until", RESERVED },
            { @"while", RESERVED },
            { @"+", RESERVED },
            { @"-", RESERVED },
            { @"*", RESERVED },
            { @"/", RESERVED },
            { @"%", RESERVED },
            { @"^", RESERVED },
            { @"#", RESERVED },
            { @"&", RESERVED },
            { @"~", RESERVED },
            { @"|", RESERVED },
            { @"<<", RESERVED },
            { @">>", RESERVED },
            { @"//", RESERVED },
            { @" ", RESERVED },
            { @"(", RESERVED },
            { @")", RESERVED },
            { @"{", RESERVED },
            { @"}", RESERVED },
            { @"[", RESERVED },
            { @"]", RESERVED },
            { @"::", RESERVED },
            { @";", RESERVED },
            { @":", RESERVED },
            { @",", RESERVED },
            { @".", RESERVED },
            { @"..", RESERVED },
            { @"...", RESERVED },
            { @"[0-9]+", INT },
            { @"[A-Za-z][A-Za-z0-9_]*", ID }
        };

        public string[,] LuaLex(string[] Characters)
        {
            Lexer Lexer = new Lexer();

            return Lexer.Lex(Characters, TokenExpressions);
        }
    }
}
