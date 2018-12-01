import scrapy

import Itinerario from Onibus
import Horario from Onibus
import Linha from Onibus

class Segmento(scrapy.Item):
  
    Nome = scrapy.Field()
    Logradouro = scrapy.Field()
    Linha = Nome.Linha
  



