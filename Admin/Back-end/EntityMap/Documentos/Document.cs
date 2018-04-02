using System.Text.RegularExpressions;
using Back_end.Models;

namespace Back_end.EntityMap.Documentos
{
    public abstract class Document
    {
        private string documentoIdentificacao;

        protected virtual string DocumentoIdentificacao
        {
            get
            {
                return documentoIdentificacao;
            }
            set
            {
                documentoIdentificacao = value;
            }
        }
        public abstract string ObterDocumentoFormatado();


        public string ObterDocumentoSemFormatacao()
        {
            if (DocumentoIdentificacao != null)
                DocumentoIdentificacao = Regex.Replace(DocumentoIdentificacao, "[^0-9]", "");
            return DocumentoIdentificacao;
        }

        protected abstract bool IsValid(string documento);

        protected Document(string documento)
        {
            DocumentoIdentificacao = TirarCaracteresEspeciais(documento);

            if (!IsValid(DocumentoIdentificacao)
            && !string.IsNullOrEmpty(DocumentoIdentificacao))
                throw new ExceptionBusiness("");
        }

        protected string TirarCaracteresEspeciais(string texto)
        {
            return Regex.Replace(texto, @"\D", "");
        }
    }
}