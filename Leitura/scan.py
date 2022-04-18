import cv2 as cv

# Lê a imagem
img = cv.imread('Modelos/planta_TESTE.jpg')

# Desfoca a imagem
blur = cv.GaussianBlur(img, (11,11), cv.BORDER_DEFAULT)

# Deteta as bordas da imagem
canny = cv.Canny(blur, 125, 175)
cv.imshow('Canny edges', rescaleFrame(canny))
