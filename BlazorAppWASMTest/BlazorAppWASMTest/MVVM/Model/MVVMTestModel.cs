using Microsoft.VisualBasic;
using System.Net.Http.Headers;

namespace BlazorAppWASMTest.MVVM.Model
{
    public class MVVMTestModel
    {
        public string PCName { get; set; }

        public MVVMTestModel()
        {

        }

        public async Task InitializeAsync()
        {
            Console.WriteLine("MVVMTestModel InitializeAsync Start.");
            
            // 何かしらのサービスを利用してデータを初期化する。
            await Task.Delay(1000);

            this.PCName = "InitPCName";

            Console.WriteLine("MVVMTestModel InitializeAsync Done.");
            return;

        }
    }
}
