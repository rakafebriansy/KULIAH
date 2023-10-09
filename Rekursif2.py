n = int(input("Masukkan jumlah menu: "))
menu = {}
for i in range(n):
    id, parent, label = input("Masukkan id, parent, dan label menu (dipisahkan dengan spasi): ").split()
    menu[id] = {"parent": parent, "label": label}
def print_menu(menu, parent, indent):
    for id, data in menu.items():
        if data["parent"] == parent:
            print(" " * indent + id + " " + data["label"])
            print_menu(menu, id, indent + 4)
print_menu(menu,"0",0)