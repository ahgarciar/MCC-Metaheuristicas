##                 ins1 ins2 ....
iqr_algoritmo_1 = [100, 20, 80, 70, 96, 90]
iqr_algoritmo_2 = [100, 80, 100, 100, 91, 95]
iqr_algoritmo_3 = [90, 95, 75, 15, 85, 90]  ##  propuesta
iqr_algoritmo_4 = [90, 60, 70, 80, 51, 85]

##
#LAS PRUEBAS POSTHOC TIENEN UTILIDAD SOLO CUANDO EXISTE UNA DIFERENCIA
#ESTADISTICA ENTRE LOS GRUPOS Y SE DESEA CONCOER AL GRUPO O GRUPOS
#QUE SON DIFERENTES
############################################################
import numpy as np
data = np.array([iqr_algoritmo_1, iqr_algoritmo_2, iqr_algoritmo_3, iqr_algoritmo_4])
############################################################

from scikit_posthocs import posthoc_nemenyi_friedman #pip install scikit-posthocs
res = posthoc_nemenyi_friedman(data.T)
print(res)

