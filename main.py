import sys
import tensorflow as tf
from tensorflow.keras.models import load_model
from tensorflow.keras.preprocessing.image import load_img, img_to_array
import os
import numpy as np

# Configurer l'encodage de la sortie standard
sys.stdout.reconfigure(encoding='utf-8')

# Charger le modèle entraîné
model = load_model("C:/Users/hp/Desktop/modele zettam/mon_modele2.keras")

# Mapper les indices de classe aux noms de classe
class_names = {
    0: "minor",
    1: "moderate",
    2: "severe"
}

def predict_class(image_path):
    # Charger et prétraiter l'image
    img = load_img(image_path, target_size=(224, 224))
    img_array = img_to_array(img)
    img_array = np.expand_dims(img_array, axis=0)
    img_array = img_array / 255.0  # Normalisation des valeurs de pixels
    
    # Redirection de la sortie standard vers un objet StringIO temporaire
    import io
    import sys
    sys.stdout = io.StringIO()

    # Faire la prédiction
    predictions = model.predict(img_array)
    predicted_class_index = np.argmax(predictions[0])
    predicted_class_name = class_names[predicted_class_index]
    
    # Récupération de la sortie standard sous forme de chaîne de caractères
    output = sys.stdout.getvalue()

    # Restauration de la sortie standard
    sys.stdout = sys.__stdout__

    # Retourner la classe prédite
    return predicted_class_name

# Chemin vers le répertoire contenant les images téléchargées
image_folder = r"C:\Users\hp\Downloads\assia (5)\assia\assia\data3a\test"

# Parcourir les images dans le répertoire et afficher la classe prédite pour chaque image
i = 1
for image_filename in os.listdir(image_folder):
    image_path = os.path.join(image_folder, image_filename)
    # Nettoyer le nom du fichier en remplaçant les caractères indésirables
    clean_filename = image_filename.replace("indesirable", "")
    # Afficher la classe prédite pour chaque image
    predicted_class = predict_class(image_path)
    print(f"Nom de l'image : {clean_filename}, sa classe est : {predicted_class}")

    i += 1