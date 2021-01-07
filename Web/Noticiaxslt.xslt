<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="/">
    <table >


      <tr style ="background-color: #C0C0C0">
        <td style=" border: thin double #800000"> IdNoticia </td>
        <td style=" border: thin double #800000"> Titulo </td>
        <td style=" border: thin double #800000"> Relevante </td>
        <td style=" border: thin double #800000"> FechaHoraCreacion </td>
        <td style=" border: thin double #800000"> NomPeriodista </td>
        <td style=" border: thin double #800000"> Categoria </td>
      </tr>


      <xsl:for-each select="Raiz/Noticia">
        <tr>
          <td>
            <xsl:value-of select="IdNoticia" />
          </td>
          <td>
            <xsl:value-of select="Titulo" />
          </td>
          <td>
            <xsl:value-of select="Relevante" />
          </td>
          <td>
            <xsl:value-of select="FechaHoraCreacion" />
          </td>
          <td>
            <xsl:value-of select="NomPeriodista" />
          </td>
          <td>
            <xsl:value-of select="Categoria" />
          </td>
        </tr>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>
