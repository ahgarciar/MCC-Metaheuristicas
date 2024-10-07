
##                 ins1 ins2 ....
iqr_algoritmo_1 = [100, 20, 80, 70, 96, 90]
iqr_algoritmo_2 = [100, 80, 100, 100, 91, 95]
iqr_algoritmo_3 = [90, 95, 75, 15, 85, 90]  ##  propuesta
iqr_algoritmo_4 = [90, 60, 70, 80, 51, 85]

print(iqr_algoritmo_1)
print(iqr_algoritmo_2)
print(iqr_algoritmo_3)

#Friedman Test
from scipy import stats
res = stats.friedmanchisquare(iqr_algoritmo_1, iqr_algoritmo_2, iqr_algoritmo_3, iqr_algoritmo_4)
#Ho = hipotesis nula...
# NO EXISTE DIFERENCIA ESTADISTICA ENTRE LAS MUESTRAS (GRUPOS)
#Ha = hipostesis alternativa
# EXISTE DIFERENCIA ESTADISTICA ENTRE LAS MUESTRAS (GRUPOS)

#EVALUACION DE LA PRUEBA....Si pvalue < 0.05 se rechaza Ho y se acepta Ha

#ES DECIR SI pvalue >= 0.05 se acepta Ho y se rechaza Ha

print(res)
