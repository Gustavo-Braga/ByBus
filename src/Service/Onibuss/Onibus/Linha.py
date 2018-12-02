import scrapy
import Empresa from Onibus 
import Linhas from Onibus 

class Linha(scrapy.Item):
 
    Nome = scrapy.Field()
    CNPJ = Empresa.CNPJ
      
