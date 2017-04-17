Introduction to Developing C# Applications for MultiChain

MultiChain is a private blockchain platform based on a fork of Bitcoin Core. (http://www.multichain.com/developers/)
These materials are designed to supplement the technical documentations on the official website and demonstrate how some of the advanced concepts can be implemented with JSON-RPC API calls using C#. Students are advised to refer to the lecture notes for more details. The repository also include sessions for illustrating core Bitcoin concepts. The sessions are designed to cater for students with differing levels of programming skillsets, C#/JSON expertise or Visual Studio experience. The focus here is about learning how to use MultiChain, not programming.

1. Grant RPC access from external network to MultiChain
   *  Find the port to be use for RPC
      run “getblockchainparams”
      find the value for “default-rpc-port” : “[rpcport] ”
      find the value for “chain-name”:”[chainname]”
   *  Open multichain.conf file
      Go to blockchain location ~/.multichain/chain1
      nano multichain.conf file
   *  Open node for RPC from external network
      multichain.conf file should show 2 lines like the following:
        rpcuser=[rpcuser]
        rpcpassword=[rpcpassword]
      Add a new line:
        rpcallowip=0.0.0.0/0
      Note down [rpcuser] and [rpcpassword]

NOTE: 
Setting rpcallowip=0.0.0.0/0 effectively allow anyone program the node externally. In practise, this should be configured behind firewall accessible by application server only. This is different from the mining port which is used by inter-node connections and consensus.

2. Class.MultichainLib project

    * Contains utility classes to be used by you:
      CryptoHelper - helper for hash and encryption functions.
      Hex – helper for hexadecimal conversions.
      JsonRpcClient - making JsonRpcRequest API calls.
      MultichainHelper - helper for JsonRpcClient.

    * Contains Multichain access classes to be implemented by you:
      Admin – Blockchain level functions
      AssetManager – Multichain assets
      PermissionManager – Multichain permissions
      StreamManager – Multichain streams
      TransactionManager – Managing raw transactions

    * JsonRpcRequest() helper method
      The method can be found in JsonRpcClient.cs
      It is used to make JSON-RPC API calls and returns result as a string

      public string JsonRpcRequest(string method, params object[] args)
      {
          Dictionary<string, object> mcArgs = new Dictionary<string, object>()
          {
          { "method",method },
          { "chain_name",ChainName },
          { "params", args }
          };
          …
          using (var handler = new HttpClientHandler() { Credentials = new NetworkCredential(RpcName, RpcPassword) })
            …
            using (var response = client.PostAsync(string.Format("http://{0}:{1}/", NodeIp, NodePort), new StringContent(jsonRpcRequest,
            Encoding.UTF8, "text/plain")).Result)
      }

      Make sure the constructor settings are correct for it to work.

    * Handling JSON API errors
        The result returned from MultiChain JSON-RPC API follows this structure:
        { 
          “result”: {…}, 
          “error” : 
          {
            “code”:-8,
            “message”:”Invalid permission”
          }, 
          “id” : {}
        }
        If “error” is not null then something wrong has happened. Follow the message to investigate.

    * Get() helper method
      The method can be found in JsonRpcClient.cs
      It is used to evaluate the result from the JSON-RPC API calls.
        public static dynamic Get(string json)
        {
            dynamic result = JsonConvert.DeserializeObject(json);
            if (result.error != null)
                throw new Exception(result.error.message.ToString());
            return result.result;
        }
      If “error” is found in the JSON result, then an exception is thrown with Multichain error message.
      Otherwise, it returns a dynamic object for extracting data.

    * Example:
      JsonRpcClient jsonRpcClient = new JsonRpcClient("[rpcusername]", 	"[rpcpassword]", "[rpcnetworkip]", rpcport, "[chainname]");
      try
      {
        var json = jsonRpcClient.JsonRpcRequest(“getinfo”);
        dynamic result = JsonRpcClient.Get(json);
        Console.WriteLine(result.description);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }

    * Handling JSON in C# 
      JSON objects can be passed to JsonRpcRequest using anonymous types, eg. 
        new { name = “asset1”, qty = 1000}
    
    * JSON objects can retrieved into dynamic type  using JsonConvert, eg. 
        dynamic result = JsonConvert.DeserializeObject(jsonString)

    * Multichain access classes (Admin, AssetManager, etc)
    These classes are for you to get use to using C# to access Multichain API.
    Most of methods are designed to throw an exception until you implement it.

    Eg.
    public string GetInfo()
    {
      throw new NotImplementedException();
    }

    Methods that are implemented are for your reference to show some C# constructs in more complex uses, eg.
    Eg.
     public string CreateRawSendFrom(string addressFrom, string addressTo, string assetname, int qty)
        {
            return jsonRpcClient.JsonRpcRequest("createrawsendfrom", addressFrom, new Dictionary<string, object> 
          	{ { addressTo, new Dictionary<string, int> { { assetname, qty } } } }, null, "sign");
        }

3. Getting Started
    * Each project represents a programming session to be executed in sequence.
    * You must right-click on the target project and select "Set As Startup Project" to run each session.
    * Click on Visual Studio View from main menu bar and select "Task List"
    * A new tab called "Task List" should appear at the bottom panel.
    * Select the filter on the column header "Project" for the current project.
    * Follow the instructions to complete each task in sequence.






    
