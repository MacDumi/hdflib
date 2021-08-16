namespace hdflib.Example
{
    class CreateDatasetExample
    {
        static void Main(string[] args)
        {
            double scalar = 12.0;
            double[] vector = new double[] { 1, 2 };
            double [,] matrix = new double[,] { { 3, 4 }, { 5, 6 } };

            string[,] textMat = new string[,] { { "text", "is" }, { "also", "supported" } };

            // Create test.h5 file
            using (HDFWriter w = new HDFWriter("test.h5"))
            {
                // put all examples in the group "dataset_0"
                w.CreateAttribute("/dataset_0", "Title", "Description"); // string attribute
                w.CreateDataset("/dataset_0/scalar", scalar); // a single value
                w.CreateDataset("/dataset_0/vector", vector); // an array or vector
                w.CreateDataset("/dataset_0/matrix", matrix); // a 2d matrix 
                w.CreateDataset("/dataset_0/txt_mat", textMat); // a 2d text matrix
            }

            // Open test.h5 file and add data to it
            using (HDFWriter w = new HDFWriter("test.h5", false))
            {
                // put all examples in the group "dataset_1"
                w.CreateAttribute("/dataset_1", "Title", "Description"); // string attribute
                w.CreateDataset("/dataset_1/scalar", scalar); // a single value
                w.CreateDataset("/dataset_1/vector", vector); // an array or vector
                w.CreateDataset("/dataset_1/matrix", matrix); // a 2d matrix 
                w.CreateDataset("/dataset_1/txt_mat", textMat); // a 2d text matrix
            }
        }
    }
}
