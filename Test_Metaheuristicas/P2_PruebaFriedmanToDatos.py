import numpy as np
import pandas as pd
from scipy import stats

datos = np.array([
    [100, 100, 90, 90], #instancia 1
    [20, 80, 95, 60], # instancia 2
    [80, 100, 75, 70], #intancia 3
    [70, 100, 15, 80],
    [96, 91, 85, 51],
    [90, 95, 90, 85]
])


df = pd.DataFrame(datos, columns=["iqr_algoritmo_1", "iqr_algoritmo_2", "iqr_algoritmo_3", "iqr_algoritmo_4"])

ranking = df.apply(stats.rankdata, axis=1)
print("Columnas Rankeadas:")
print(ranking)
ranking_promedio = ranking.mean()
print("Ranking Promedio:")
print(ranking_promedio)


#Friedman Test
res = stats.friedmanchisquare(*[df[columna] for columna in df])
#Ho = hipotesis nula...
# NO EXISTE DIFERENCIA ESTADISTICA ENTRE LAS MUESTRAS (GRUPOS)
#Ha = hipostesis alternativa
# EXISTE DIFERENCIA ESTADISTICA ENTRE LAS MUESTRAS (GRUPOS)
#EVALUACION DE LA PRUEBA....Si pvalue < 0.05 se rechaza Ho y se acepta Ha
# SI pvalue >= 0.05 se acepta Ho y se rechaza Ha
print(res)
