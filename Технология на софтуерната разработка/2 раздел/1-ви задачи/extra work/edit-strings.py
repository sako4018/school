s = 'User {name}: {n} new messages'
s.format(name = 'Den', n = 55)

name = 'Den'
n = 55
s.format_map(vars())

