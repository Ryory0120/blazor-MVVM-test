using BlazorAppWASMTest.MVVM.Model;

namespace BlazorAppWASMTest.MVVM.ViewModel
{
    public class MVVMTestViewModel
    {
        public string PCName { get; set; } = String.Empty;

        private MVVMTestModel mVVMTestModel;

        public MVVMTestViewModel()
        {
            this.mVVMTestModel = new MVVMTestModel();
        }

        public async Task InitializeAsync()
        {
            Console.WriteLine("MVVMTestViewModel InitializeAsync Start.");
            await Task.Delay(1000);
            // Modelの初期化
            await this.mVVMTestModel.InitializeAsync();

            Console.WriteLine("MVVMTestViewModel InitializeAsync Done.");

            // Modelから受け取ったデータを加工
            Console.WriteLine("Modelから受け取ったデータの加工開始");
            this.PCName = this.mVVMTestModel.PCName;
            Console.WriteLine("Modelから受け取ったデータの加工終了");

            return;
        }
    }
}
