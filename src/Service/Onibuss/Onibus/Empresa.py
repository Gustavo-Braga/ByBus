import scrapy 

class Empresa(scrapy.Item):

    CNPJ = scrapy.Field()
    Nome = scrapy.Field()
    
  
