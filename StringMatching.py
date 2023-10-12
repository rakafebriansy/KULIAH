def match(text,pat, i = 0):
    ipat = len(pat)
    if text[i:ipat+i] == pat:
        return i
    else:
        return match(text,pat, i+1)
print('Posisi pola pada indeks ke',match('102302165651453888610973555','165'))

NO_OF_CHARS = 256
def badCharHeuristic(string, size):
	badChar = [-1]*NO_OF_CHARS
	for i in range(size):
		badChar[ord(string[i])] = i
	return badChar
def search(txt, pat):
	m = len(pat)
	n = len(txt)
	badChar = badCharHeuristic(pat, m)
	s = 0	
	while(s <= n-m):
		j = m-1
		while j>=0 and pat[j] == txt[s+j]:
			j -= 1
		if j<0:
			print("Posisi pola pada indeks ke {}".format(s))
			s += (m-badChar[ord(txt[s+m])] if s+m<n else 1)
		else:
			s += max(1, j-badChar[ord(txt[s+j])])
txt = '10230216565143888610973555'
pat = '165'
search(txt, pat)