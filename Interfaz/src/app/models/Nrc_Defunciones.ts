import { NumberSymbol } from "@angular/common";

export interface Nrc_Defunciones{
     numeroacta:number;
     anioregistro:number;
     entidadregistro:number;
     municipioregistro:number;
     oficilia:number;
     actabis:string;
     cadena:string;
     cofecharegistro?:Date | null;
     cofecharegistroinc:string | null;
     collaveregistrocivil:string | null;
     cofoja?: number | null;
     cotomo?:number | null;
     colibro?:number | null;
     imnombreoriginalimagen?:string | null;
     imarchivo:string | null;
     nanumeroacta?:number | null;
     naanioregistro?:number | null;
     natipodocumento?:number | null;
     naentidadregistro?:number | null;
     namunicipioregistro?:number | null;
     naoficialia?:number | null;
     naactabis:string | null;
     otnotasmarginales:string | null;
     otcrip:string | null;
     otcausadefuncion:string;
     otfechadefuncion:Date;
     otfechadefuncioninc:string | null;
     ottipodefuncion:string;
     peprimerapellido:string;
     pesegundoapellido:string;
     penombres:string;
     peedad?:number | null;
     pesexo:string;
     pefechanacimiento?:Date | null;
     pefechanacimientoinc:string | null;
     peentidadnacimiento?:number;
     pemunicipionacimiento?:number;
     pelocalidadnacimiento:string;
     penacionalidad?:number;
     pepaisnacimiento?:number;
     pecurp:string | null;
     paprimerapellido:string;
     pasegundoapellido:string;
     panombres:string;
     paedad?:number | null;
     pasexo:string;
     pafechanacimiento?:Date | null;
     pafechanacimientoinc:string | null;
     paentidadnacimiento?:number | null;
     pamunicipionacimiento?:number | null;
     palocalidadnacimiento:string | null;
     panacionalidad?:number | null;
     papaisnacimiento?:number | null;
     pacurp:string | null;
     panumeroacta?:number | null;
     paanioregistro?:number | null;
     patipodocumento?:number | null;
     paentidadregistro?:number | null;
     pamunicipioregistro?:number | null;
     paoficialia?:number | null;
     paactabis:string | null;
     manumeroacta?:number | null;
     maanioregistro?:number | null;
     matipodocumento?:number | null;
     maentidadregistro?:number | null;
     mamunicipioregistro?:number | null;
     maoficialia?:number | null;
     maactabis:string | null;
     maprimerapellido:string;
     masegundoapellido:string;
     manombres:string;
     maedad?:Date | null;
     masexo:string;
     mafechanacimiento?:Date | null;
     mafechanacimientoinc:string | null;
     maentidadnacimiento?:number | null;
     mamunicipionacimiento?:number | null;
     malocalidadnacimiento:string | null;
     manacionalidad?:number | null;
     mapaisnacimiento?:number | null;
     macurp:string | null;
     cyprimerapellido:string;
     cysegundoapellido:string;
     cynombres:string;
     cyedad?:number | null;
     cysexo:string;
     cyfechanacimiento?:Date | null;
     cyfechanacimientoinc:string | null;
     cyentidadnacimiento?:number | null;
     cymunicipionacimiento?:number | null;
     cylocalidadnacimiento:string | null;
     cynacionalidad?:number;
     cypaisnacimiento?:number | null;
     cycurp:string | null;
     cynumeroacta?:number | null;
     cyanioregistro?:number | null;
     cytipodocumento?:number| null;
     cyentidadregistro?:number| null;
     cymunicioregistro?:number| null;
     cyoficialia?:number| null;
     cyactabis:string| null;
     cnfechaactualizacion?:Date | null;
     cnfechaactualizacioninc:string | null;
     cnfechacaptura?:Date;
     oterrororigen:string | null;
     otfecharegistronacimientoinc:string | null;
     otfecharegistroennacimiento?:Date | null;
     otestadocivildifunto:string;
     otfirma:string | null;
     otllaverenadi:string | null;
     otsello:string| null;
     otlocalidaddefuncion:string| null;
     tmpfecha?:Date;
     otcertificadode:string | null;
     otmeses?:number;
     otdias?:number;
     othoras?:number;
     otminutos?:number;
     otsegundos?:number;
     tipocadena?:number;
     cotipo?:string;
     cofechaoriginal:Date | null;
     cotranscripcion:string;
     cosoporte:string | null
}