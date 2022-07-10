import cv2
import random
import numpy as np

imageLocation = open(r"C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\imagemselecionada.txt", "r").read().strip()


img = cv2.imread(imageLocation)
#img = cv2.imread("minha4.png")

gray = cv2.cvtColor(img, cv2.COLOR_RGB2GRAY)

_, thresh = cv2.threshold(gray, 127, 255, cv2.THRESH_BINARY)

#cv2.imshow("thresh", thresh)

mor_img = cv2.morphologyEx(thresh, cv2.MORPH_OPEN, (3, 3), iterations=3)

contours, hierarchy = cv2.findContours(mor_img, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

sorted_contours = sorted(contours, key=cv2.contourArea, reverse=True)

numdivisoes = 0
i=0

area_list = list()

for c in sorted_contours[2:]:
    i=i+1
    aarea = 0
    perimetro = 0
    area = cv2.contourArea(c)
    perimeter = cv2.arcLength(c,True)
    perimetro = perimeter/110
    aarea = (perimetro/4)**2  #se nao for so com 4 lados nao funciona!!!

    print("Divisão %d\nÁrea: %.3f\nPermimetro: %.3f" % (i,round(aarea,3),round(perimetro,3)))

    
    if area > 1:
        numdivisoes=numdivisoes+1       
        area_list.append(area)
        cv2.drawContours(img, [c], -1, (random.randrange(0, 255), random.randrange(0, 256), random.randrange(0, 255)), 3)
           
aarea = 0
perimetro = 0
area = cv2.contourArea(sorted_contours[1])
perimeter = cv2.arcLength(sorted_contours[1],True)
perimetro = perimeter/110 #passar de pixeis para cm 
aarea = (perimetro/4)**2  #se nao for so com 4 lados nao funciona!!!

print("Área Total: %.3f\nPerimetro: %.3f\n" % (round(aarea,3),round(perimetro,3)))
            
print ("numero de divisoes:", numdivisoes)

num_div_final = numdivisoes -1

#cv2.imshow("mor_img", mor_img)
#cv2.imshow("img", img)

#cv2.waitKey(0)

#cv2.imwrite(r'C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\output_imagem.png',img)


# with open(r'C:\Users\User\Desktop\ISCAC\3ANO2SEMESTRE\PDI\projeto\output.txt',"w") as f:
#    f.write("%s\n" %  (str(num_div_final)))
#    for area in area_list:
#       f.write("%s\n" % (str(area)))

