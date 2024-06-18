#include <iostream>
#include <string>

using namespace std;

class NPC
{
private:
	int id;
	string name;
	string faction;
	int age;
	int level;
	int friendship;
	int romance;
	int fear;

public:
	NPC() : name(""), id(0), faction(""), age(0), level(0), friendship(0), romance(0), fear(0) {}
	NPC(string name, string faction, int age, int level, int friendship, int romance, int fear)
	{
		this->id = 0;
		this->name = name;
		this->faction = faction;
		this->age = age;
		this->level = level;
		this->friendship = friendship;
		this->romance = romance;
		this->fear = fear;

		cout << this->name << " apareceu na cena.";
	}
	~NPC()
	{
		cout << this->name << " saiu de cena.";
	}

	void showName()
	{
		cout << this->name << endl;
	}

	void addFriendship(int x)
	{
		this->friendship += x;
	}

	void addRomance(int x)
	{
		this->romance += x;
	}

	void addFear(int x)
	{
		this->romance += x;
	}

	void Dialogo()
	{
		int opt = 0;

		cout << "Testando sistema de diálogo em C++" << endl;
		cout << "Escolha uma opção\n1 - Atacar\n2 - Conversar" << endl;

		cin >> opt;

		if (opt == 1)
			cout << "Combate!";
		else if (opt == 2)
			cout << "Meu nome é " << this->name << " e tenho " << this->age << " anos." << endl;
	}
};

class Player
{
private:
	string name;
	int id;

public:
	Player() : name(""), id(0) {}
	Player(string name, int id)
	{
		this->id = id;
		this->name = name;
	}
	void setName(string n) { name = n; }
	int getID() const { return id; }
	string getName() const { return name; }
	void printName() const { cout << name << endl; }
	void printId() { cout << hex << uppercase << this->id << endl; }
	virtual void teste() { cout << "faça seu teste" << endl; }
};

// CELULA DUPLA
class Celula
{
private:
	Player p;

public:
	Celula *next;
	Celula *prev;
	Celula(Player p)
	{
		this->next = this->prev = nullptr;
		this->p = p;
	}

	Player getValue() { return this->p; }
};

class Lista
{
private:
	Celula *primeiro;
	Celula *ultimo;

public:
	Lista() : primeiro(nullptr), ultimo(nullptr)
	{
		primeiro = new Celula(Player());
		ultimo = primeiro;
	}

	~Lista()
	{
		while (primeiro != nullptr)
		{
			Celula *temp = primeiro;
			primeiro = temp->next;
			delete temp;
		}
	}

	void InserirInicio(Player p)
	{
		cout << "Inserindo player " << p.getName() << " no início da lista." << endl;

		Celula *nova = new Celula(p);
		nova->prev = primeiro;
		nova->next = primeiro->next;
		primeiro->next = nova;

		if (primeiro == ultimo)
			ultimo = nova;
		else
			nova->next->prev = nova;

		nova = nullptr;
	}

	void InserirFim(Player p)
	{
		cout << "Inserindo player " << p.getName() << " no final da lista." << endl;

		ultimo->next = new Celula(p);
		ultimo->next->prev = ultimo;
		ultimo = ultimo->next;
	}

	void Inserir(Player p)
	{
		cout << "Inserindo player " << p.getName() << " na lista." << endl;

		InserirFim(p);
	}

	void Inserir(Player p, int pos)
	{
		cout << "Inserindo player " << p.getName() << " na posição " << pos << "." << endl;

		int tamanho = Tamanho();
		if (pos < 0 || pos > tamanho)
			throw "Erro";
		else if (pos == 0)
			InserirInicio(p);
		else if (pos == tamanho)
			InserirFim(p);
		else
		{
			Celula *c = primeiro;
			for (int i = 0; i < pos; i++, c = c->next)
				;
			Celula *nova = new Celula(p);
			nova->prev = c;
			nova->next = c->next;
			nova->prev->next = nova->next->prev;
			nova = c = nullptr;
		}
	}

	int Tamanho()
	{
		Celula *c = primeiro->next;
		int count;

		for (count = 0; c != nullptr; c = c->next, count++)
			;
		return count;
	}

	void Mostrar()
	{
		Celula *aux = primeiro->next;

		cout << "[ ";
		while (aux != nullptr)
		{
			cout << aux->getValue().getID() << ": " << aux->getValue().getName() << (aux->next == nullptr ? "" : ", ");
			aux = aux->next;
		}
		cout << "]" << endl;
	}

	int GetSize()
	{
		Celula *aux = primeiro->next;
		int size = 0;

		while (aux != nullptr)
		{
			size++;
			aux = aux->next;
		}

		return size;
	}

	int GetLastID()
	{
		return ultimo->getValue().getID();
	}
};

void teste()
{
	int x = 0;
	x++;

	if (x == 1)
		return;
	else
		cout << "do nothing";
}

int main()
{
	string input;
	int quantidade;
	Lista *l = new Lista();

	cout << "Tamanho: " << l->Tamanho() << endl;
	cout << "Quantos players você deseja? ";
	cin >> quantidade;

	cin.ignore();

	for (int i = 0; i < quantidade; i++)
	{
		cout << "Digite o nome do player: ";
		getline(cin, input);

		l->InserirFim(Player(input, l->GetLastID() + 0x1));
		l->Mostrar();
	}

	NPC *brunus = new NPC("Brunus", "Tartessos", 18, 10, 0, 0, 0);

	brunus->Dialogo();

	delete brunus;
	cout << "Fim do programa";
}