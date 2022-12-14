export interface Nrc_Nacimientos{
    numeroacta:number;
    anioregistro:number;
    tipodocumento?:number | null;
    entidadregistro:number;
    municipioregistro:number;
    oficilia:number;
    actabis:string;
    cadena:string;
    coFechaRegistro?:Date | null;
    coFechaRegistroInc?: string | null;
    coLlaveregistrocivil?: string | null;
    coFoja?: number | null;

    

    coTomo?:number | null;
    coLibro?:number | null;
    imNombreoriginalimagen: string | null;
    imArchivo:string | null;
    otNotasmarginales:string | null;
    otCrip:string | null;
    otVivoomuerto: string | null;


    pePrimerapellido:string | null;
    peSegundoapellido:string | null;
    peNombres:string | null;
    peEdad:number | null;
    peSexo:string | null;
    peFechanacimiento:Date | null;
    peFechanacimientoinc:string | null;
    peEntidadnacimiento?:number | null;
    peMunicipionacimiento?:number | null;
    peLocalidadnacimiento:string | null;
    peNacionalidad?:number | null;
    pePaisnacimiento?:number | null;
    peCurp :string | null;

    paPrimerapellido  :string | null;
    paSegundoapellido:string | null;
    paNombres:string | null;
    paEdad:number | null;
    paSexo:string | null;
    paFechanacimiento:Date | null;
    paFechanacimientoinc:string | null;
    paEntidadnacimiento?:number | null;
    paMunicipionacimiento?:number | null;
    paLocalidadnacimiento:string | null;
    paNacionalidad?:number | null;
    paPaisnacimiento?:number | null;
    paCurp :string | null;
    paNumeroacta?:number;
    paAnioregistro?:number;
    paTipodocumento?:number | null;
    paEntidadregistro?:number;
    paMunicipioregistro?:number;
    paOficilia?:number;
    paActabis?:string;

    maNumeroacta?:number;
    maAnioregistro?:number;
    maTipodocumento?:number | null;
    maEntidadregistro?:number;
    maMunicipioregistro?:number;
    maOficilia?:number;
    maActabis?:string;
    maPrimerapellido  :string | null;
    maSegundoapellido:string | null;
    maNombres:string | null;
    maEdad:number | null;
    maSexo:string | null;
    maFechanacimiento:Date | null;
    maFechanacimientoinc:string | null;
    maEntidadnacimiento?:number | null;
    maMunicipionacimiento?:number | null;
    maLocalidadnacimiento:string | null;
    maNacionalidad?:number | null;
    maPaisnacimiento?:number | null;
    maCurp :string | null;

    cnFechaactualizacion?: Date | null;
    cnFechaactualizacioninc: string | null;
    cnFechacaptura?: Date | null;
    otErrororigen?: string | null;
    otFecharegistronacimientoinc?: string
    otFirma?: string| null;
    otSello?:string| null;
    tmpFecha?: Date | null;
    otCertificadona: string | null;
    nactoid?: number | null; 
    tipocadena?:number | null;
    coTipo?:string | null;
    coFechaoriginal?:Date | null;  
    coTranscripcion?:string| null;
    coSoporte?:string| null;

    //otregistropatrimonial?:number | null;
   
      
      
      
      

      
      
      
     
      
     
}