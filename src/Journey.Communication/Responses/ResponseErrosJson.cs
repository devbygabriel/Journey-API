﻿namespace Journey.Communication.Responses
{
    public class ResponseErrosJson
    {
        public IList<string> Errors { get; set; } = [];
        public ResponseErrosJson(IList<string> erros)
        {
            Errors = erros;
        }

    }
}
