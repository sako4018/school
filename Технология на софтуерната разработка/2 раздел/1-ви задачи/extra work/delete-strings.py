s = ' hello world \n'
s.strip()

s.lstrip()
s.rstrip()

t = '----hello===='
t.lstrip('-')
t.strip('-=')

s.replace(' ', '')
import re
re.sub('\s+', ' ', s)

