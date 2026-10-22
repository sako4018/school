text = 'yeah, but no, but yeah, but no, but yeah'
text.replace('yeah','yep')



text = 'Today 21/10/2026. Next date 23/10/2026'
import re
re.sub(r'(\d+) / (\d+) / (\d+)', r'\3-\1-\2', text)



