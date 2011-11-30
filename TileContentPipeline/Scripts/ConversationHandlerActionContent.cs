﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace TileContent
{
    public class ConversationHandlerActionContent
    {
        public string MethodName;
        public object[] ActionParameters;
    }

    [ContentTypeWriter]
    public class ConversationHandlerActionWriter : ContentTypeWriter<ConversationHandlerActionContent>
    {
        protected override void Write(ContentWriter output, ConversationHandlerActionContent value)
        {
            // TODO: write the specified value to the output ContentWriter.
            output.Write(value.MethodName);
            output.WriteObject(value.ActionParameters);
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            // TODO: change this to the name of your ContentTypeReader
            // class which will be used to load this data.
            return "TileEngine.ConversationHandlerActionReader, TileEngine";
        }
    }
}
