import cv2
import random

#imageLocation = r'C:\Users\Red\Downloads\minha3.png'

img = cv2.imread(imageLocation)

gray = cv2.cvtColor(img, cv2.COLOR_RGB2GRAY)

_, thresh = cv2.threshold(gray, 127, 255, cv2.THRESH_BINARY)

#cv2.imshow("thresh", thresh)

mor_img = cv2.morphologyEx(thresh, cv2.MORPH_OPEN, (3, 3), iterations=3)

contours, hierarchy = cv2.findContours(mor_img, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

sorted_contours = sorted(contours, key=cv2.contourArea, reverse=True)

numdivisoes = 0

area_list = list()

for c in sorted_contours[1:]:
    area = cv2.contourArea(c)
    if area > 100:
        numdivisoes=numdivisoes+1
        print (area)
        area_list.append(area)
        cv2.drawContours(img, [c], -1, (random.randrange(0, 255), random.randrange(0, 256), random.randrange(0, 255)), 3)

print (numdivisoes-1)

num_div_final = numdivisoes -1

#cv2.imshow("mor_img", mor_img)
#cv2.imshow("img", img)

#cv2.waitKey(0)

cv2.imwrite(r'C:\Users\maksy\Desktop\ISCAC\output_imagem.png',img)

with open(r'C:\Users\maksy\Desktop\ISCAC\output.txt',"w") as f:
    f.write("%s\n" %  (str(num_div_final)))
    for area in area_list:
       f.write("%s\n" % (str(area)))
