using System;
using System.Runtime.Serialization;

namespace ApiCatalogoJogos.Controllers.V1
{
    [Serializable]
    internal class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
        {
        }

        public JogoJaCadastradoException(string message) : base(message)
        {
        }

        public JogoJaCadastradoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JogoJaCadastradoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}