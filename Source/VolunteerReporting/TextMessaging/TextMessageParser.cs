/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017 International Federation of Red Cross. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Linq;
using Concepts;
namespace TextMessaging
{
    // /// summary
    // /// Represents an implementation of <see cref="ITextMessageContentParser"/>
    // /// summary
    // public class TextMessageParser : ITextMessageParser
    // {
    //     private static readonly char[] Separators = new[] { '#', '*' };

    //     /// <inheritdoc/>
    //     public TextMessageParsingResult Parse(TextMessage textMessage)
    //     {
    //         var content = textMessage.Message;
            
    //         var fragments = content.Replace(" ", string.Empty).Split(Separators).Select(s => new TextMessageFragment(s));
    //         var result = new TextMessageParsingResult(fragments);
    //         return result;
    //     }
    // }
}