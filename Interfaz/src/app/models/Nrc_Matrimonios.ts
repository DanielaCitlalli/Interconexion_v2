export interface Nrc_Matrimomios{
    numeroacta?:number;
    anioregistro?:number;
    tipodocumento?:number;
    entidadregistro?:number;
    municipioregistro?:number;
    oficilia?:number;
    actabis?:string;
    cadena?:string;
    co_fecha_registro?:Date | null;
    co_llaveregistrocivil?: string | null;
    co_foja?: number | null;

    

    co_tomo?:number | null;
    co_libro?:number | null;
    ot_crip_p1?:string | null;
    ot_crip_p2?:string | null;
    im_nombreoriginalimagen?:string | null;
    ot_notasmarginales?:string | null;
    ot_registropatrimonial?:number | null;
    p1_nombres?:string | null;
    p1_primerapellido?:string | string;
    p1_segundoapellido?:string;

  
    p1_fechanacimiento?: Date | null;
    p1_sexo?: string | null;
    p1_edad?: number | null;
    p1_nacionalidad?:number | null;
    p1_paisnacimiento?: number | null;
    p1_entidadnacimiento?: number | null;
    p1_municipionacimiento?: number | null;
    p1_localidadnacimiento?:  string | null;
    p1_numeroacta?: number | null;
    P1_anioregistro?: number | null;
    p1_tipodocumento?: number | null;

   p1_municipioregistro?:number | null;
   p1_oficialia?:number | null;
   p1_entidadregistro?:number | null;
   p1_actabis?:number | null;
   p1_curp?:number | null;
   p1_cadena?:number | null;
   p2_nombres?:string;
   p2_primerapellido?:string;
   p2_segundoapellido?:string;
   p2_fechanacimiento?:number | null;


      p2_sexo?: string | null;
      P2_edad?: number | null;
      p2_nacionalidad?:number | null;
      p2_paisnacimiento?: number | null;
      p2_entidadnacimiento?: number | null;
      p2_municipionacimiento?: number | null;
      p2_localidadnacimiento?:  string | null;
      p2_numeroacta?: string | null;
      p2_anioregistro?: number | null;
      p2_tipodocumento?: number | null;
      p2_entidadregistro?: number | null;
//59 empiezas con este P2_MUNICIPIOREGISTRO sipi
//entonces empiezo desde la 60 en adelante jajaja ok deja la busco 
//dani

     p2_municioioregistro?:number | null;
     p2_oficialia?:number | null;
     p2_ACTABISactabis?:number | null;
     p2_curp?:number | null;
     p2_cadena?:number | null;
     p1_pa_nombres?:number | null;
     p1_pa_primerapellido?:number | null;
     p1_pa_segundoapellido?:number | null;
     p1_pa_numeroacta?:number | null;
     p1_pa_anioregistro?:number | null;
     p1_pa_tipodocumento?:number | null;

//chris
      p1_pa_entidadregistro?: number | null;
      p1_pa_municipioregistro?: number | null;
      p1_pa_oficilia?: number | null;
      p1_pa_actabis?: string | null;
      p1_pa_curp?: string | null;
      p1_pa_nacionalidad?: number | null;
      p1_pa_cadena?: string | null;
      p1_ma_nombres?: string | null;
      p1_ma_primerapellido?: string | null;
      p1_ma_segundoapellido?: string | null;

      
//dani
      p1_ma_numeroacta?: number | null;
      p1_ma_anioregistro?: number | null;
      p1_ma_tipodocumento?:string | null;
      p1_ma_entidadregistro?:number | null;
      p1_ma_municipioregistrado?:string | null;
      p1_ma_oficialia?:number | null;
      p1_ma_actabis?:string | null;
      p1_ma_curp?:string | null;
      p1_ma_nacionalidad?:string | null;
      p1_ma_cadena?:number | null;
      
//chris
      p2_pa_nombres?: string | null;
      p2_pa_primerapellido?: string | null;
      p2_pa_segundoapellido?: string | null;
      p2_pa_numeroacta?: number | null;
      p2_pa_anioregistro?: number | null;
      p2_pa_tipodocumento?: number | null;
      p2_pa_entidadregistro?: number | null;
      p2_pa_municipioregistro?: number | null;
      p2_pa_oficialia?: number | null;
      p2_pa_actabis?: string | null;
      //dani

      p2_pa_curp?:number;
      p2_pa_nacionalidad?:string | null;
      p2_pa_cadena?:number;
      p2_ma_nombres?:string;
      p2_ma_primerapellido?:string;
      p2_ma_segundoapellido?:string;
      p2_ma_numeroacta?:number | null;
      p2_ma_anioregistro?:Date | null;
      p2_ma_tipodocumento?:string | null;
      p2_mentidadregistro?:number | null;
     
//chris
      p2_ma_municipioregistro?: number | null;
      p2_ma_oficialia?: number | null;
      p2_ma_actabis?: string | null;
      p2_ma_curp?: string | null;
      p2_ma_nacionalidad?: number | null;
      p2_ma_cadena?: string | null;
      cn_fechaactualizacion?: Date | null;
      cn_fechacaptura?: Date | null;
      ot_errororigen?: string | null;
      ot_firma?: string| null;
      
//dani
      ot_sello?:string| null;
      p1_pa_sexo?:string;
      p1_ma_sexo?:string;
      p2_pa_sexo?:string;
      p2_ma_sexo?:string;
      tipocadena?:number | null;
      im_archivo?:string | null;
      co_tipo?:number | null;
      co_fechaoriginal?:Date | null;
      co_transcripcion?:string| null;
      co_soporte?:string| null;
}