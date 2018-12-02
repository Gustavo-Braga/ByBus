import scrapy
import Linha from Onibus

class Segmento(scrapy.Item):
  
    Nome = scrapy.Field()
    Logradouro = scrapy.Field()
    Linha = Nome.Linha
  



