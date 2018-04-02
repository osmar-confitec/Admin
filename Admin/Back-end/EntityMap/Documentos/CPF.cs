namespace Back_end.EntityMap.Documentos
{
    public class CPF : Document
    {
        protected CPF(string documento) : base(documento)
        {
        }

        public override string ObterDocumentoFormatado()
        {
            throw new System.NotImplementedException();
        }

        protected override bool IsValid(string documento)
        {
            throw new System.NotImplementedException();
        }
    }
}