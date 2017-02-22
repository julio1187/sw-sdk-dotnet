﻿namespace SW.Helpers
{
    internal class DataDemoResponse
    {
        private string _token = "T2lYQ0t4L0RHVkR4dHZ5Nkk1VHNEakZ3Y0J4Nk9GODZuRyt4cE1wVm5tbXB3YVZxTHdOdHAwVXY2NTdJb1hkREtXTzE3dk9pMmdMdkFDR2xFWFVPUTQyWFhnTUxGYjdKdG8xQTZWVjFrUDNiOTVrRkhiOGk3RHladHdMaEM0cS8rcklzaUhJOGozWjN0K2h6R3gwQzF0c0g5aGNBYUt6N2srR3VoMUw3amtvPQ.T2lYQ0t4L0RHVkR4dHZ5Nkk1VHNEakZ3Y0J4Nk9GODZuRyt4cE1wVm5tbFlVcU92YUJTZWlHU3pER1kySnlXRTF4alNUS0ZWcUlVS0NhelhqaXdnWTRncklVSWVvZlFZMWNyUjVxYUFxMWFxcStUL1IzdGpHRTJqdS9Zakw2UGQwRTE2OTN2ZGE2QXR6QlczOWlvZVBQREtFZkxCRXA5ZE5jOEdYbUpYQ0hKa0U5YmxvejNFNk9oczhjNjJPSXVDSU93bzAxNlpUczZTdHpHRnRuUDY4OTk5NWZCVDBYQUo0MFBrWktxMGV1ZlV5VGsrRUNJdTZubHR2dEpxdlkya0VtRm9MZFRYQWdac1lCcFFOS1I2TEw2WFhMSXFYUGpyWE5pejFtbFA5N3Z1eGxpNmVGbmx4RFBMTHB3RXdzbGhVcDNkcVFyc0JUNHo0WFdqWUNwN2Y5Zkd5K0M3cWV6RG95SFpyQTlDbTVnOEtGbDh1U0gwZHAvdUJJbk5vazJRR09xblk3UG8vTUIvUEtWb015M2t0ZHNRdzJHbW9haW0zaUVMOGVIeGVlL3NTNFJ4dWk4anZ1Z214aVM0UWZYSU1oK2hjYVpYSGFmQlRBd1ZralB4SG1iekxxODJWNXBTcXhIbXNkSjZjSTlXU0RveFhTTlA4aStwdTNETkhXRmM.hCe6onZdKGCA4m3vrqiHpAL6UwoYz47sNzI7yzyH7QA";

        private string _cfdi = @"<?xml version='1.0' encoding='utf-8'?><cfdi:Comprobante xsi:schemaLocation='http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd' version='3.2' serie='G' folio='108' LugarExpedicion='NNNNNN ,NNNN' NumCtaPago='No Identificado' fecha='2017-02-14T10:22:12' sello='VFdZUY66KQHzR0Q5yKUYz9i9VuSol7xsCvZesnP+X0NcWbSHAWWOtPWboqOcyvGSJow3dZ5pmYcGCm3jvaVXTJS+J5u4CQpEZFs096grXl7nytRG1KZqjRB2BjY3sfnjPIplcWqwM9H6vk8bkUTuQKcOJMN/C+amP4Aa+tsUJRA=' formaDePago='Pago en una sola exhibición' noCertificado='20001000000200001428' certificado='MIIEYTCCA0mgAwIBAgIUMjAwMDEwMDAwMDAyMDAwMDE0MjgwDQYJKoZIhvcNAQEFBQAwggFcMRowGAYDVQQDDBFBLkMuIDIgZGUgcHJ1ZWJhczEvMC0GA1UECgwmU2VydmljaW8gZGUgQWRtaW5pc3RyYWNpw7NuIFRyaWJ1dGFyaWExODA2BgNVBAsML0FkbWluaXN0cmFjacOzbiBkZSBTZWd1cmlkYWQgZGUgbGEgSW5mb3JtYWNpw7NuMSkwJwYJKoZIhvcNAQkBFhphc2lzbmV0QHBydWViYXMuc2F0LmdvYi5teDEmMCQGA1UECQwdQXYuIEhpZGFsZ28gNzcsIENvbC4gR3VlcnJlcm8xDjAMBgNVBBEMBTA2MzAwMQswCQYDVQQGEwJNWDEZMBcGA1UECAwQRGlzdHJpdG8gRmVkZXJhbDESMBAGA1UEBwwJQ295b2Fjw6FuMTQwMgYJKoZIhvcNAQkCDCVSZXNwb25zYWJsZTogQXJhY2VsaSBHYW5kYXJhIEJhdXRpc3RhMB4XDTEzMDUwNzE2MDEyOVoXDTE3MDUwNzE2MDEyOVowgdsxKTAnBgNVBAMTIEFDQ0VNIFNFUlZJQ0lPUyBFTVBSRVNBUklBTEVTIFNDMSkwJwYDVQQpEyBBQ0NFTSBTRVJWSUNJT1MgRU1QUkVTQVJJQUxFUyBTQzEpMCcGA1UEChMgQUNDRU0gU0VSVklDSU9TIEVNUFJFU0FSSUFMRVMgU0MxJTAjBgNVBC0THEFBQTAxMDEwMUFBQSAvIEhFR1Q3NjEwMDM0UzIxHjAcBgNVBAUTFSAvIEhFR1Q3NjEwMDNNREZOU1IwODERMA8GA1UECxMIcHJvZHVjdG8wgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBAKS/beUVy6E3aODaNuLd2S3PXaQre0tGxmYTeUxa55x2t/7919ttgOpKF6hPF5KvlYh4ztqQqP4yEV+HjH7yy/2d/+e7t+J61jTrbdLqT3WD0+s5fCL6JOrF4hqy//EGdfvYftdGRNrZH+dAjWWml2S/hrN9aUxraS5qqO1b7btlAgMBAAGjHTAbMAwGA1UdEwEB/wQCMAAwCwYDVR0PBAQDAgbAMA0GCSqGSIb3DQEBBQUAA4IBAQACPXAWZX2DuKiZVv35RS1WFKgT2ubUO9C+byfZapV6ZzYNOiA4KmpkqHU/bkZHqKjR+R59hoYhVdn+ClUIliZf2ChHh8s0a0vBRNJ3IHfA1akWdzocYZLXjz3m0Er31BY+uS3qWUtPsONGVDyZL6IUBBUlFoecQhP9AO39er8zIbeU2b0MMBJxCt4vbDKFvT9i3V0Puoo+kmmkf15D2rBGR+drd8H8Yg8TDGFKf2zKmRsgT7nIeou6WpfYp570WIvLJQY+fsMp334D05Up5ykYSAxUGa30RdUzA4rxN5hT+W9whWVGD88TD33Nw55uNRUcRO3ZUVHmdWRG+GjhlfsD' subTotal='1.00' TipoCambio='1.0000' Moneda='MXN' total='1.00' metodoDePago='NA' tipoDeComprobante='ingreso' xmlns:cfdi='http://www.sat.gob.mx/cfd/3' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'><cfdi:Emisor rfc='AAA010101AAA' nombre='RAZON SOCIAL NOMBRE'><cfdi:DomicilioFiscal calle='CALLE PRUEBAS' noExterior='6969' colonia='COLONIA PRUEBAS' localidad='LOCALIDAD PRUEBAS' municipio='ZAPOPAN' estado='JALISCO' pais='MÉXICO' codigoPostal='45000' /><cfdi:RegimenFiscal Regimen='GENERAL DE LEY PERSONAS MORALES' /></cfdi:Emisor><cfdi:Receptor rfc='XEXX010101000' nombre='NOMBRE CLIENTE'><cfdi:Domicilio calle='CALLE CLEINTE' noExterior='6969' colonia='COLONIA CLIENTE' localidad='LOCALIDAD CLIENTE' municipio='MUNICIPIO CLIENTRE' estado='ESTADO CLIENTE' pais='PAIS CLIENTE' codigoPostal='6969' /></cfdi:Receptor><cfdi:Conceptos><cfdi:Concepto cantidad='1' unidad='No Aplica' noIdentificacion='1' descripcion='1' valorUnitario='1' importe='1.000000' /></cfdi:Conceptos><cfdi:Impuestos /><cfdi:Complemento><tfd:TimbreFiscalDigital xsi:schemaLocation='http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/TimbreFiscalDigital/TimbreFiscalDigital.xsd' version='1.0' UUID='32b13e1a-a871-4b23-9b3f-9e6a84e13f14' FechaTimbrado='2017-02-14T10:27:05' selloCFD='VFdZUY66KQHzR0Q5yKUYz9i9VuSol7xsCvZesnP+X0NcWbSHAWWOtPWboqOcyvGSJow3dZ5pmYcGCm3jvaVXTJS+J5u4CQpEZFs096grXl7nytRG1KZqjRB2BjY3sfnjPIplcWqwM9H6vk8bkUTuQKcOJMN/C+amP4Aa+tsUJRA=' noCertificadoSAT='20001000000300022323' selloSAT='gB7dQHUewdQQgELp3kVNnlemdkFPkL+ySK9GOQCb/6kaRbPx9OP0a3DiHab6L+tVP690XI4paWFGb52LFvrSUPZu7DZ+OF/wbwdLDKXqy1eBzRTjxGEi4pmkMJ46e+9cnTCTSEl3xyNHdg1VTXrF5wr4RX4M/+1R56ANscIyWfTAPDyYDePLNAJ83/dAtA6oy/XXG44URU7YKEem/HMCKcrr3ttCHDzbmJS8C41lepE0xpcQlUKAnLp44cAcJW418mjC0rdsHsCJXKymL3qMt4JDM4Roeq9c5E3+U4b2kp6fF/203s4gBiEl370xMuBjaSrBVfi6J/ySmRtuQtClcg==' xmlns:tfd='http://www.sat.gob.mx/TimbreFiscalDigital' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' /></cfdi:Complemento></cfdi:Comprobante>";

        private string _tfd = "<tfd:TimbreFiscalDigital xsi:schemaLocation='http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/TimbreFiscalDigital/TimbreFiscalDigital.xsd' version='1.0' UUID='32b13e1a-a871-4b23-9b3f-9e6a84e13f14' FechaTimbrado='2017-02-14T10:27:05' selloCFD='VFdZUY66KQHzR0Q5yKUYz9i9VuSol7xsCvZesnP+X0NcWbSHAWWOtPWboqOcyvGSJow3dZ5pmYcGCm3jvaVXTJS+J5u4CQpEZFs096grXl7nytRG1KZqjRB2BjY3sfnjPIplcWqwM9H6vk8bkUTuQKcOJMN/C+amP4Aa+tsUJRA=' noCertificadoSAT='20001000000300022323' selloSAT='gB7dQHUewdQQgELp3kVNnlemdkFPkL+ySK9GOQCb/6kaRbPx9OP0a3DiHab6L+tVP690XI4paWFGb52LFvrSUPZu7DZ+OF/wbwdLDKXqy1eBzRTjxGEi4pmkMJ46e+9cnTCTSEl3xyNHdg1VTXrF5wr4RX4M/+1R56ANscIyWfTAPDyYDePLNAJ83/dAtA6oy/XXG44URU7YKEem/HMCKcrr3ttCHDzbmJS8C41lepE0xpcQlUKAnLp44cAcJW418mjC0rdsHsCJXKymL3qMt4JDM4Roeq9c5E3+U4b2kp6fF/203s4gBiEl370xMuBjaSrBVfi6J/ySmRtuQtClcg==' xmlns:tfd='http://www.sat.gob.mx/TimbreFiscalDigital' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' />";

        private string _acuse = "<?xml version='1.0' encoding='utf-8'?><Acuse xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' RfcEmisor='AAA010101AAA' Fecha='2017-01-23T18:29:45.8319708'><Folios xmlns='http://cancelacfd.sat.gob.mx'><UUID>862FC064-DB80-4F1C-876D-658BECE063AD</UUID><EstatusUUID>201</EstatusUUID></Folios><Signature Id='SelloSAT' xmlns='http://www.w3.org/2000/09/xmldsig#'><SignedInfo><CanonicalizationMethod Algorithm='http://www.w3.org/TR/2001/REC-xml-c14n-20010315' /><SignatureMethod Algorithm='http://www.w3.org/2001/04/xmldsig-more#hmac-sha512' /><Reference URI=''><Transforms><Transform Algorithm='http://www.w3.org/TR/1999/REC-xpath-19991116'><XPath>not(ancestor-or-self::*[local-name()='Signature'])</XPath></Transform></Transforms><DigestMethod Algorithm='http://www.w3.org/2001/04/xmlenc#sha512' /><DigestValue>C3rhI8/HtsMhXHZkJk6tHILvrNAad1nUn81tmTFpGNN8w+qvmze9i+qp2uSqh4Wsxy+3trZYf3zS39T+1lmkfQ==</DigestValue></Reference></SignedInfo><SignatureValue>Q3x14WMVu5CvviTcSHje3CiCZWyMR/orOBgg9n9awYaOjUhCHxh74wWwMN8PGC1NeM5vYo2Io5PyXQviAyr+0A==</SignatureValue><KeyInfo><KeyName>00001088888810000001</KeyName><KeyValue><RSAKeyValue><Modulus>vAr6QLmcvW6auTg7a+Ogm0veNvqJ30rD3j0iSAHxGzGVrg1d0xl0Fj5l+JX9EivD+qhkSY7pfLnJoObLpQ3GGZZOOihJVS2tbJDmnn9TW8fKUOVg+jGhcnpCHaUPq/Poj8I2OVb3g7hiaREORm6tLtzOIjkOv9INXxIpRMx54cw46D5F1+0M7ECEVO8Jg+3yoI6OvDNBH+jABsj7SutmSnL1Tov/omIlSWausdbXqykcl10BLu2XiQAc6KLnl0+Ntzxoxk+dPUSdRyR7f3Vls6yUlK/+C/4FacbR+fszT0XIaJNWkHaTOoqz76Ax9XgTv9UuT67j7rdTVzTvAN363w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue></KeyValue></KeyInfo></Signature></Acuse>";

        public DataDemoResponse()
        {
        }
        internal SW.Services.Stamp.Data Stamp()
        {
            return new SW.Services.Stamp.Data()
            {
                cfdi = _cfdi,
                tfd = _tfd
            };
        }
        internal string Authentication()
        {
            return _token;
        }
        internal string Cancelation()
        {
            return _acuse;
        }
    }
}