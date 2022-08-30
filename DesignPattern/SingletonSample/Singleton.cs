using System;

public class Singleton {
    private static Singleton singleton;

    //�R���X�g���N�^
    private Singleton() { }

    public static Singleton getInstance()
    {
        if (singleton == null)
        {
            singleton = new Singleton();
        }
        return singleton;
    }
}
