import pandas,numpy
from sklearn.model_selection import train_test_split   
from sklearn.tree import DecisionTreeClassifier
from sklearn.metrics import classification_report
from sklearn.preprocessing import LabelBinarizer

df = pandas.read_csv("adult.csv")
data = df.head(100)

X = numpy.array(data["capital.loss"])
y = numpy.array(data["sex"]) #0 = Female, 1 = Male
lb = LabelBinarizer()
y = lb.fit_transform(y).flatten()
X_train, X_test, y_train, y_test = train_test_split(X,y,test_size=0.3,random_state=1)
model = DecisionTreeClassifier(max_depth=3, min_samples_leaf=5, random_state=1)
model.fit(X_train.reshape(-1,1),y_train.reshape(-1,1))
y_pred = model.predict(X_test.reshape(-1,1))
print(classification_report(y_test.reshape(-1,1), y_pred))
