import pandas #PREPROCESS
df = pandas.read_csv('datamhs.csv')
def selectionsort(dataframe,operand):
    for i in range(len(dataframe)-1):
        min_idx = i 
        for j in range(i+1,len(dataframe)):
            if operand == 'tertinggi' and dataframe.loc[j,'nilai'] > dataframe.loc[min_idx,'nilai']:
                min_idx = j
            elif operand == 'terendah' and dataframe.loc[j,'nilai'] < dataframe.loc[min_idx,'nilai']:
                min_idx = j
        if min_idx != i:
            dataframe.iloc[[i,min_idx]] = dataframe.iloc[[min_idx,i]].values
    return dataframe
def insertionsort(dataframe):
    for i in range(1, len(dataframe)): 
        key = dataframe.loc[i]
        j = i-1
        while j >=0 and key.nilai == dataframe.loc[j, 'nilai'] and key.nama < dataframe.loc[j,'nama']:
                dataframe.iloc[j+1] = dataframe.iloc[j].values 
                j -= 1
        dataframe.iloc[j+1] = key.values
    return dataframe
print(insertionsort(selectionsort(df,input('Urut nilai berdasarkan? (tertinggi/terendah)\n\n')))) #PROCESS