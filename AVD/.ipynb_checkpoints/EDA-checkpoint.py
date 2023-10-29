import pandas,matplotlib.pyplot as plt, seaborn

#DATA PROFILING#
data = pandas.read_csv("DATA PENJUALAN ALAT KANTOR.csv") #load dataset
df = pandas.DataFrame(data) #modelling
print(f"Rata-rata\n\tPenjualan = {df['Penjualan'].mean()}\n\tKuantitas = {df['Kuantitas'].mean()}\n\tProfit = {df['Profit'].mean()}") #mean
print(f"Median\n\tPenjualan = {df['Penjualan'].median()}\n\tKuantitas = {df['Kuantitas'].median()}\n\tProfit = {df['Profit'].median()}") #median
print(f"Modus\n\tID Konsumen = {df['ID Konsumen'].mode().values[0]}\n\tSegmen = {df['Segmen'].mode().values[0]}\n\tRegion = {df['Region'].mode().values[0]}\n\tProduct ID = {df['Product ID'].mode().values[0]}\n\tKategori = {df['Kategori'].mode().values[0]}\n\tSub-Kategori = {df['Sub-Kategori'].mode().values[0]}") #modus
print(f"Varians\n\tPenjualan = {df['Penjualan'].var()}\n\tKuantitas = {df['Kuantitas'].var()}\n\tProfit = {df['Profit'].var()}") #variance
print(f"Simpang baku\n\tPenjualan = {df['Penjualan'].std()}\n\tKuantitas = {df['Kuantitas'].std()}\n\tProfit = {df['Profit'].std()}") #standard deviation

#NULL VALUES DETECTING#
print(df.isnull().sum()) #check null values

#NULL VALUES HANDLING#
df["Segmen"] = df.Segmen.fillna(df.Segmen.mode().values[0])
df["Region"] = df.Region.fillna(df.Region.mode().values[0])
df["Sub-Kategori"] = df["Sub-Kategori"].fillna(df["Sub-Kategori"].mode().values[0])
df["Penjualan"] = df.Penjualan.fillna(df.Penjualan.median())
df["Kuantitas"] = df.Kuantitas.fillna(df.Kuantitas.median())
df["Profit"] = df.Profit.fillna(df.Profit.median())
print(df.isnull().sum()) #check null values

#OUTLIERS DETECTION
cols = df.columns[6:9]
for i in cols:
    seaborn.boxplot(y=df[i])
plt.show()