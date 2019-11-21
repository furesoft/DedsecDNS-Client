using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DedSecDns_Client.Core.Styling.Parser
{
    /// <summary>
    /// 	Class to parse CSS text into data structures.
    /// </summary>
    public class CssParser : TextParser
    {
        /// <summary>
        /// 	Moves to the next occurrence of the specified character, skipping
        /// 	over quoted Contents.
        /// </summary>
        /// <param name="c"> Character to find </param>
        public new void MoveTo(char c)
        {
            while (Peek() != c && !EndOfText)
            {
                if (IsQuote())
                    SkipOverQuote();
                else
                    MoveAhead();
            }
        }

        public IEnumerable<CssParserDeclaration> ParseAll(string css)
        {
            int start;

            Reset(css);
            StripAllComments();

            var rules = new List<CssParserDeclaration>();

            while (!EndOfText)
            {
                MovePastWhitespace();

                // Parse declarations
                MoveAhead();
                start = Position;
                MoveTo('}');
                string properties = Extract(start, Position);
                rules.AddRange(from s in properties.Split(';')
                               let s2 = s.Trim()
                               where s2.Length > 0
                               let x = s2.IndexOf(':')
                               select new CssParserDeclaration
                               {
                                   Property = s2.Substring(0, (x < 0) ? 0 : x).TrimEnd(),
                                   Value = s2.Substring((x < 0) ? 0 : x + 1).TrimStart()
                               });

                // Skip over closing curly brace
                MoveAhead();
            }

            // Return rules to caller
            return rules;
        }

        protected const string CloseComment = "*/";
        protected const string OpenComment = "/*";

        /// <summary>
        /// 	Calls the specified action and then returns a string of all characters
        /// 	that the method skipped over.
        /// </summary>
        /// <param name="a"> Action to call </param>
        /// <returns> </returns>
        protected string ExtractSkippedText(Action a)
        {
            int start = Position;
            a();
            return Extract(start, Position);
        }

        /// <summary>
        /// 	Indicates if a comment begins at the current location.
        /// </summary>
        protected bool IsComment()
        {
            return IsEqualTo(OpenComment);
        }

        /// <summary>
        /// 	Determines if text at the current position matches the specified string.
        /// </summary>
        /// <param name="s"> String to compare against current position </param>
        protected bool IsEqualTo(string s)
        {
            Debug.Assert(!String.IsNullOrEmpty(s));
            for (int i = 0; i < s.Length; i++)
            {
                if (Peek(i) != s[i])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 	Indicates if single or double-quoted text begins at the current
        /// 	location.
        /// </summary>
        protected bool IsQuote()
        {
            return (Peek() == '\'' || Peek() == '"');
        }

        /// <summary>
        /// 	Skips over the comment that starts at the current position.
        /// </summary>
        protected void SkipOverComment()
        {
            Debug.Assert(IsComment());
            MoveAhead(OpenComment.Length);
            MoveTo(CloseComment, true);
            MoveAhead(CloseComment.Length);
        }

        /// <summary>
        /// 	Skips over the quoted text that starts at the current position.
        /// </summary>
        protected void SkipOverQuote()
        {
            Debug.Assert(IsQuote());
            char quote = Peek();
            MoveAhead();
            while (Peek() != quote && !EndOfText)
                MoveAhead();
            MoveAhead();
        }

        /// <summary>
        /// 	Removes all comments from the current text.
        /// </summary>
        protected void StripAllComments()
        {
            var sb = new StringBuilder();

            Reset();
            while (!EndOfText)
            {
                if (IsComment())
                {
                    SkipOverComment();
                }
                else if (IsQuote())
                {
                    sb.Append(ExtractSkippedText(SkipOverQuote));
                }
                else
                {
                    sb.Append(Peek());
                    MoveAhead();
                }
            }
            Reset(sb.ToString());
        }

        /// <summary>
        /// 	Moves to the next whitespace character.
        /// </summary>
        private void MoveToWhiteSpace()
        {
            while (!Char.IsWhiteSpace(Peek()) && !EndOfText)
                MoveAhead();
        }

        /// <summary>
        /// 	Skips over a block of text bounded by the specified start and end
        /// 	character. Blocks may be nested, in which case the endChar of
        /// 	inner blocks is ignored (the entire outer block is returned).
        /// 	Sets the current position to just after the final end character.
        /// </summary>
        /// <param name="startChar"> </param>
        /// <param name="endChar"> </param>
        private void SkipOverBlock(char startChar, char endChar)
        {
            Debug.Assert(Peek() == startChar);
            MoveAhead();
            int depth = 1;
            while (depth > 0 && !EndOfText)
            {
                if (IsQuote())
                {
                    SkipOverQuote();
                }
                else
                {
                    if (Peek() == startChar)
                        depth++;
                    else if (Peek() == endChar)
                        depth--;
                    MoveAhead();
                }
            }
        }
    }
}