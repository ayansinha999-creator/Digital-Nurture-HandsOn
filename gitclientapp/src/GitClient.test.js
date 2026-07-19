import axios from "axios";
import GitClient from "./GitClient";

jest.mock("axios");

describe("Git Client Tests", () => {

  test("should return repository names for techiesyed", async () => {

    const repositories = [
      { id: 1, name: "Repo1" },
      { id: 2, name: "Repo2" }
    ];

    axios.get.mockResolvedValue({
      data: repositories
    });

    const response = await GitClient.getRepositories("techiesyed");

    expect(axios.get).toHaveBeenCalledWith(
      "https://api.github.com/users/techiesyed/repos"
    );

    expect(response.data).toEqual(repositories);

  });

});